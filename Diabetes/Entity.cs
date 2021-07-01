using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Diabetes
{
    public class Admin
    {
        private int ano;
        private String name;
        private int age;
        private String sex;
        private String phone;
        private String email;
        private String password;

        public Admin()
        {
        }

        public Admin(int ano, string name, int age, string sex, string phone, string email, string password)
        {
            this.ano = ano;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.phone = phone;
            this.email = email;
            this.password = password;
        }

        public int Ano { get => ano; set => ano = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }

    public class Diagnosis
    {
        private int digno;
        private int pno;
        private int dno;
        private String type;
        private DateTime time;
        private String description;

        public Diagnosis()
        {
        }

        public Diagnosis(int digno, int pno, int dno, string type, DateTime time, string description)
        {
            this.digno = digno;
            this.pno = pno;
            this.dno = dno;
            this.type = type;
            this.time = time;
            this.description = description;
        }

        public int Digno { get => digno; set => digno = value; }
        public int Pno { get => pno; set => pno = value; }
        public int Dno { get => dno; set => dno = value; }
        public string Type { get => type; set => type = value; }
        public DateTime Time { get => time; set => time = value; }
        public string Description { get => description; set => description = value; }

        public static Diagnosis ToBean(SqlDataReader reader)
        {
            Diagnosis diagnosis = new Diagnosis();
            if (reader.Read())
            {
                diagnosis = new Diagnosis(Convert.ToInt32(reader["digno"].ToString()), Convert.ToInt32(reader["pno"].ToString()), Convert.ToInt32(reader["dno"].ToString()), 
                    reader["type"].ToString(), Convert.ToDateTime(reader["time"].ToString()), reader["description"].ToString());

            }
            return diagnosis;
        }
    }

    public class Doctor
    {
        private int dno;
        private String name;
        private int age;
        private String sex;
        private String phone;
        private String password;
        private bool identification;
        private int patientsNum;

        public Doctor()
        {
        }

        public Doctor(int dno, string name, int age, string sex, string phone, string password, bool identification, int patientsNum)
        {
            this.dno = dno;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.phone = phone;
            this.password = password;
            this.identification = identification;
            this.patientsNum = patientsNum;
        }

        public int Dno { get => dno; set => dno = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public bool Identification { get => identification; set => identification = value; }
        public int PatientsNum { get => patientsNum; set => patientsNum = value; }

        public static Doctor ToBean(SqlDataReader reader)
        {
            Doctor doctor = new Doctor();
            if (reader.Read())
            {
                doctor = new Doctor(Convert.ToInt32(reader["dno"].ToString()), reader["name"].ToString(), Convert.ToInt32(reader["age"].ToString()), reader["sex"].ToString(), reader["phone"].ToString(),
                    reader["password"].ToString(), Convert.ToBoolean(reader["identification"].ToString()), Convert.ToInt32(reader["patientsNum"].ToString()));

            }
            return doctor;
        }
    }
    public class GlycemicIndex
    {
        private int pno;
        private decimal value;
        private DateTime time;

        public GlycemicIndex()
        {
        }

        public GlycemicIndex(int pno, decimal value, DateTime time)
        {
            this.pno = pno;
            this.value = value;
            this.time = time;
        }

        public int Pno { get => pno; set => pno = value; }
        public decimal Value { get => value; set => this.value = value; }
        public DateTime Time { get => time; set => time = value; }

        public static GlycemicIndex ToBean(SqlDataReader reader)
        {
            GlycemicIndex glycemicIndex = null;
            if(reader.Read())
            {
                glycemicIndex = new GlycemicIndex(Convert.ToInt32(reader["pno"].ToString()), Convert.ToDecimal(reader["value"].ToString()), Convert.ToDateTime(reader["time"].ToString()));
            }
            return glycemicIndex;
        }

        public static List<GlycemicIndex> ToBeanList(SqlDataReader reader)
        {
            GlycemicIndex glycemicIndex = null;
            List<GlycemicIndex> list = new List<GlycemicIndex>();
            while (reader.Read())
            {
                glycemicIndex = new GlycemicIndex(Convert.ToInt32(reader["pno"].ToString()), Convert.ToDecimal(reader["value"].ToString()), Convert.ToDateTime(reader["time"].ToString()));
                list.Add(glycemicIndex);
            }
            return list;
        }

    }
    public class Patient
    {
        private int pno;
        private String name;
        private int age;
        private String sex;
        private String phone;
        private String password;
        private int attendingDoctor;
        private String type;

        public int Pno { get => pno; set => pno = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public int AttendingDoctor { get => attendingDoctor; set => attendingDoctor = value; }
        public string Type { get => type; set => type = value; }

        public Patient() { }
        public Patient(int pno, string name, int age, string sex, string phone, string password, int attendingDoctor, string type)
        {
            this.pno = pno;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.phone = phone;
            this.password = password;
            this.attendingDoctor = attendingDoctor;
            this.type = type;
        }
        public static Patient ToBean(SqlDataReader reader)
        {
            Patient patient = null;
            if (reader.Read())
            {
                patient = new Patient(Convert.ToInt32(reader["pno"].ToString()), reader["name"].ToString(), Convert.ToInt32(reader["age"].ToString()), reader["sex"].ToString(), reader["phone"].ToString(),
                    reader["password"].ToString(), Convert.ToInt32(reader["attendingDoctor"].ToString()), reader["type"].ToString());

            }
            return patient;
        }

        public override bool Equals(object obj)
        {
            return obj is Patient patient &&
                   pno == patient.pno &&
                   name == patient.name &&
                   age == patient.age &&
                   sex == patient.sex &&
                   phone == patient.phone &&
                   password == patient.password &&
                   attendingDoctor == patient.attendingDoctor &&
                   type == patient.type &&
                   Pno == patient.Pno &&
                   Name == patient.Name &&
                   Age == patient.Age &&
                   Sex == patient.Sex &&
                   Phone == patient.Phone &&
                   Password == patient.Password &&
                   AttendingDoctor == patient.AttendingDoctor &&
                   Type == patient.Type;
        }
    }
    public class Prescription
    {
        private int digno;
        private String medicine;

        public Prescription()
        {
        }

        public Prescription(int digno, string medicine)
        {
            this.digno = digno;
            this.medicine = medicine;
        }

        public int Digno { get => digno; set => digno = value; }
        public string Medicine { get => medicine; set => medicine = value; }

        public static Prescription ToBean(SqlDataReader reader)
        {
            Prescription prescription = null;
            if (reader.Read())
            {
                prescription = new Prescription(Convert.ToInt32(reader["digno"].ToString()), reader["medicine"].ToString());

            }
            return prescription;
        }
    }
}
