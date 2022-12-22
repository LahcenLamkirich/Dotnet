namespace DOTNET.Entities 
 {
    class Account {

        public int id {get;set;}
        public String? currency{get;set;} 
        public double? amount{get;set;} 

        // Constructor :
        public Account(){}
        public Account(int id, String curr, double amount){
            this.id = id;
            this.currency = curr; 
            this.amount = amount;
        }
    }
 }