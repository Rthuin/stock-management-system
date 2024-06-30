using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace BusinessLayer.Abstract
{
	public interface IAdminService
	{
		void AdminAdd(Admin admin);
		void AdminRemove(Admin admin);
		void AdminUpdate(Admin admin);
		List<Admin> GetAllAdmins();
		Admin GetAdmin(int id);
	}
}
