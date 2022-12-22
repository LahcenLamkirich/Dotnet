using DOTNET.Entities ; 

namespace DOTNET.Services {

    interface AccountService {
        void addAccount(Account acc);
        void delete(int id);
        Account updateAccount(int id);
        List<Account> getAllAccounts();
    }
}