
using GetARoom.BLL.Exceptions;
using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL
{
    public static class RepoValidation 
    {
        //
        private static int NegativeNumberValidation(int id)
        {
            if (id > 0)
            {

                return id;

            }
            else
            {
                throw new NegativeNumberInDatabaseSearchException($"The provided id [{id}] is invalid. Provide a positive number from 1 - ...");
            }
        }

        private static int NotInDatabaseException(int id)
        {
            //TODO: NotInDatabaseException
            return id;
           
        }


        public static void ValidateIdSearch(int id)
        {
            NegativeNumberValidation(id);

        }
    }
}
