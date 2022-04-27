using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BlazorApp1.Data;

namespace BlazorApp1.Model
{
    public class PlayerModel
    {
        public int Access_Code { get; set; }
        public string Display_Name { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }

        public PlayerModel() { }

        /// <summary>
        /// Constructor that takes the generated access code and registration info from index and creates a playermodel.
        /// </summary>
        /// <param name="accessCode"></param>
        /// <param name="registerInfo"></param>
        public PlayerModel(int accessCode, RegisterModel registerInfo)
        {
            this.Access_Code = accessCode;
            this.Display_Name = registerInfo.DisplayName;
            this.Email = registerInfo.Email;
            this.Phone_Number = registerInfo.PhoneNumber.ToString();
        }
    }
}
