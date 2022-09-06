﻿//using Batch1_DET_2022.Models;
//using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class DatabaseFirst
//    {
//        public static void Main(String[] args)
//        {
//            GetAllEmpDetails();
//            GetEmpDetailsById();
//            AddNewEmployee();
//            DeleteEmployee();
//            UpdateNewEmployee();
//            Console.ReadLine();
//            StoredProcedureWithoutPara();
//            StoredProcedureWithPara();
//            RemovingEmployeeDetails();
//            RemovingEmployeeDetails();
//            CallStoredProcwithSQLParamater_insert();
//        }
//        private static void CallStoredProcwithSQLParamater_insert()
//        {
//            var ctx = new TrainingContext();
//            var param = new SqlParameter[] {
//                        new SqlParameter() {
//                            ParameterName = "@empno",
//                            SqlDbType =  System.Data.SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 9998
//                        },
//                        new SqlParameter() {
//                            ParameterName = "@ename",
//                            SqlDbType =  System.Data.
//                            SqlDbType.VarChar,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = "LARA"},





//                        new SqlParameter() {
//                            ParameterName = "@job",
//                            SqlDbType =  System.Data.
//                            SqlDbType.VarChar,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = "EMPLOYEE"},




//                         new SqlParameter() {
//                            ParameterName = "@mgr",
//                            SqlDbType =  System.Data.
//                            SqlDbType.VarChar,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 7839},

//                         new SqlParameter() {
//                            ParameterName = "@hiredate",
//                            SqlDbType =  System.Data.
//                            SqlDbType.DateTime,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = DateTime.Now},




//                         new SqlParameter() {
//                            ParameterName = "@sal",
//                            SqlDbType =  System.Data.
//                            SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 15000},


//                         new SqlParameter() {
//                            ParameterName = "@comm",
//                            SqlDbType =  System.Data.
//                            SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 1050},



//                        new SqlParameter() {
//                            ParameterName = "@deptno",
//                            SqlDbType =  System.Data.
//                            SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 30}
//                      };



//            try
//            {
//                var result = ctx.Database.ExecuteSqlRaw("InsertEmployee @empno, @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno", param);
//                Console.WriteLine("added");
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//            Console.WriteLine("update successful");
//        }





//        private static void RemovingEmployeeDetails()
//        {
//            var ctx = new TrainingContext();
//            var Value = 515;
//            int employee = ctx.Database.ExecuteSqlRaw("DeleteEmpsDetailsByEmpno @p0", Value);
//            Console.WriteLine($"No Of Rows Affected {employee}");
//        }


//        private static void StoredProcedureWithoutPara()
//        {
//            var ctx = new TrainingContext();

//            var employees = ctx.Emps.FromSqlRaw($"GetAllEmpsDetails").ToList();


//            foreach (var e in employees)
//            {
//                Console.WriteLine(e.Ename);
//            }
//        }
//        private static void StoredProcedureWithPara()
//        {
//            try
//            {
//                var ctx = new TrainingContext();

//                var employees = ctx.Emps.FromSqlRaw("GetAllEmpsDetailsByEmpNo @p0", 9999).ToList();


//                foreach (var e in employees)
//                {
//                    Console.WriteLine(e.Ename);
//                }
//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.InnerException.Message);
//            }
//        }

//        private static void UpdateNewEmployee()
//        {
//            var ctx = new TrainingContext();
//            var employee = ctx.Emps.Where(e => e.Empno == 9999).SingleOrDefault();
//            try
//            {
//                Emp employee1 = new Emp();
//                // employee.Empno = 9999;
//                employee.Ename = "RR";
//                ctx.Update(employee);
//                ctx.SaveChanges();
//                Console.WriteLine("Updated");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.InnerException.Message);
//            }
//        }



//        private static void DeleteEmployee()

//        {
//            var ctx = new TrainingContext();
//            try
//            {
//                Emp employee = new Emp();
//                employee.Empno = 9999;
//                ctx.Remove(employee);
//                ctx.SaveChanges();
//                Console.WriteLine("Employee deleted");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.InnerException.Message);
//            }
//            private static void AddNewEmployee()

//            {
//                var ctx = new TrainingContext();
//                try
//                {
//                    Emp employee = new Emp();
//                    employee.Empno = 9999;
//                    employee.Ename = "Rahul R";
//                    employee.Sal = 100000;
//                    employee.Deptno = 40;
//                    employee.Job = "Trainee";
//                    ctx.Add(employee);
//                    ctx.SaveChanges();
//                    Console.WriteLine("New Employee Added");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }


//            }


//            private static void GetEmpDetailsById()
//            {
//                var ctx = new TrainingContext();
//                var employee = ctx.Emps.Where(e => e.Empno == 7698).SingleOrDefault();
//                Console.WriteLine(employee.Ename + " " + employee.Sal + " " + employee.Job);

//                //foreach (var employee in emp)
//                //{
//                //    Console.WriteLine(employee.Ename + " " + employee.Sal);
//                //}
//            }
//        }

