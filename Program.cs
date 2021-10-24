using System;

namespace SMSCtest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            
            SMSC sms = new SMSC();
            string[] r = sms.send_sms("","Hello");

        }



       
    }
}

//https://smsc.ua/api/http/

//Реализовать работу с api провайдера сообщений

//В виде класса

//Интерфейс
//-ISMSCMessage
//Классы
//-SmsMessage
//-ViberMessage

//-Credentials (авторизация)

//Service
// + Service(credentials: Credentials)
// + getBalance(): float
// +sendMessage(message: ISMSCMessage): bool
// +getMessageCost(message: ISMSCMessage): float
// +getStatus(message: ISMSCMessage): int
