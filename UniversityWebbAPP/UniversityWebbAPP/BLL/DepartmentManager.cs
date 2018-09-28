using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityWebbAPP.DAL;
using UniversityWebbAPP.Model;

namespace UniversityWebbAPP.BLL
{
    public class DepartmentManager
    {
        public List<Department> GetAllDepartment()
        {
            DepartmetGateWay departmetGate=new DepartmetGateWay();
            return departmetGate.GetAllDepartment();

        }

        public Department GetDepartmentById(int id)
        {
            DepartmetGateWay departmetGate=new DepartmetGateWay();

            return departmetGate.GetdepartmentById(id);

        }

    }
}