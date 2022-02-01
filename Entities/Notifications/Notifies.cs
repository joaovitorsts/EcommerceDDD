using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        [NotMapped]
        public string PropertyName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;


        public bool StringPropertyValidation(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName)){
                Notifications.Add(new Notifies
                {
                    Message = "Campo Obrigatório",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }

        public bool IntPropertyValidation(int value, string propertyName)
        {
            if (value < 0 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Valor deve ser maior que 0",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }

        public bool DecimalPropertyValidation(decimal value, string propertyName)
        {
            if (value < 0 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Valor deve ser maior que 0",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }
    }
}
