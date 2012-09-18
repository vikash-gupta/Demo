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
                $.get("/api/accounts", self.accountsSummary);
            });
            this.get('#api/accounts/:accountId', function () {
                self.accountsSummary(null);
                $.get("/api/accounts/100" + this.params.accountId, self.chosenAccountDetails);
            });



            this.get('', function () { this.app.runRoute('get', '#summary') });

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