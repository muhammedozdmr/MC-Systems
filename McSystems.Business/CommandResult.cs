using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Business
{
    public class CommandResult
    {
        private const string DefaultFailureMessage = "İşlem Başarısız";
        private const string DefaultSuccessMessage = "İşlem Başarılı";
        public bool IsSucces { get; private set; }
        public string Message { get; private set; }

        public string ErrorMessage { get; private set; }

        //overload bir static metot yazarım sadece başarılı yazar aşağıdaki successi çağırır
        internal static CommandResult Success()
        {
            return Success(DefaultSuccessMessage);
        }
        internal static CommandResult Success(string message)
        {
            var commandResult = new CommandResult();
            commandResult.IsSucces = true;
            commandResult.Message = message;
            commandResult.ErrorMessage = string.Empty;
            return commandResult;
        }

        internal static CommandResult Failure(Exception exception)
        {
            return Failure(DefaultFailureMessage,exception);
        }
        internal static CommandResult Failure(string message, Exception ex)
        {
            return new CommandResult()
            {
                IsSucces = false,
                Message = message,
                ErrorMessage = ex.ToString()
            };
        }

    }
}
