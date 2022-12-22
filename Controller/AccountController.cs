using DOTNET.Services ; 
using DOTNET.Entities ; 

namespace DOTNET.Controller {
    class AccountController : AccountService {
        
        List<Account> accounts = new ArrayList<>();
        
        void addAccount(Account acc){
            accounts.add(acc);
        }

        void delete(int id){
            accounts.remove(id);
        }

        Account updateAccount(int id, String currency, double amount){
            Accont getAccount = accounts.get(id);
            getAccount.setCurrency = currency ; 
            getAccount.setAmount = amount ; 
            return getAccount ; 
        }
        
        List<Account> getAllAccounts(){
            return accounts ;
        }
        

    }
}