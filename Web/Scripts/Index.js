/// <reference path="sammy/sammy.js" />
/// <reference path="amplify.js" />
/// <reference path="amplify-vsdoc.js" />

var lastUrlKey = "Demo.LastView";
$(function () {
    function AccountViewModel() {
        // Data
        var self = this;
        self.chosenAccountDetails = ko.observable();
        self.accountsSummary = ko.observable();

        // Behaviours    
        self.goToAccount = function (account) { location.hash = "api/accounts/"+account.Id };

        // Client-side routes    
        Sammy(function () {
            this.get('#:summary', function () {
                self.chosenAccountDetails(null);
                amplify.store(lastUrlKey, "#summary");
                $.get("/api/accounts", self.accountsSummary);
            });
            this.get('#api/accounts/:accountId', function () {
                self.accountsSummary(null);
                amplify.store(lastUrlKey, "#api/accounts/" + this.params.accountId);
                $.get("/api/accounts/" + this.params.accountId, self.chosenAccountDetails);
            });
            
            var fromLocalStore = amplify.store(lastUrlKey);
            var initialView = this.getLocation() || fromLocalStore || "#summary";
            location.hash = initialView;
            this.get('', function () { this.app.runRoute('get', initialView) });

        }).run();
    };
    ko.applyBindings(new AccountViewModel());
});


//$(function () {
//    var resultsFromWebApi = $.get('api/accounts', function (data) {
//        function MyViewModel() {
//            this.accounts = data;
//        }
//        ko.applyBindings(new MyViewModel());
//    });
//    //ko.applyBindings(new AccountViewModel());
//});