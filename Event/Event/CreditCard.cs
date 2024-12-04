using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class CreditCard
    {
        private bool isStart;

        public CreditCard(string full_name, string numbers, DateOnly validity_period) 
        {
            isStart = false;
            FullName = full_name;
            Numbers = numbers;
            ValidityPeriod = validity_period;
            AmountOfMoney = 0;
            CreditMoney = 0;
        }

        public delegate void PrintHandler(string message);
        public event PrintHandler? Notify;

        public event EventHandler<EventMessageArgs>? TryOperation;

        private int pin;
        public string? Numbers { get; set; }
        public string? FullName { get; set; }
        public DateOnly ValidityPeriod { get; set; }

        public int Pin
        {
            get { return pin; }
            set
            {
                if (value < 100 || value > 999)
                {
                    throw new ArgumentOutOfRangeException();
                }
                pin = value;
            }
        }

        public double CreditMoney { get; set; }
        public double AmountOfMoney { get; set; }

        public void Take(double amount)
        {
            if(isStart)
            {
                TryOperation?.Invoke(this, new($"Передача средств со счёта: {FullName}."));
                if (amount <= AmountOfMoney)
                {
                    AmountOfMoney -= amount;
                    Notify?.Invoke($"Со счёта {FullName} было списано: {amount}.");
                }
                else
                {
                    Notify?.Invoke($"Превышен кредитный лимит {FullName}.");
                }
            }
        }

        public void Put(double amount)
        {
            TryOperation?.Invoke(this, new($"Передача средств на кредитную карту: {FullName}."));
            if(isStart)
            {
                CreditMoney -= amount;
                Notify?.Invoke($"На счёт {FullName} было положено: {amount}");
                EndCredit();
            }
            else
            {
                Notify?.Invoke("Невозможно положить деньги на карту, так как Вы не взяли кредит.");
            }
        }

        public void StartCredit(double amount_credit)
        {
            CreditMoney += amount_credit;
            AmountOfMoney += amount_credit;
            
            if(!isStart)
                isStart = true;
        }

        public void EndCredit()
        {
            if(CreditMoney <= 0)
            {
                Notify?.Invoke($"Кредит {FullName} оплачен полностью.");
                isStart = false;
            }
        }

        public void ReNamePin(int num)
        {
            TryOperation?.Invoke(this, new($"Изменение Пин-кода: {FullName}."));
            if (num < 100 || num > 999 )
            {
                Notify?.Invoke("Пин-код введён неверно. Возможно, вы ошиблись при его изменении.");
            }
            else
            {
                Notify?.Invoke("Пин-код был изменён.");
            }
        }
    }

    public class EventMessageArgs : EventArgs
    {
        public string? Message { get; }

        public EventMessageArgs(string? message)
        {
            Message = message;
        }
    }
}