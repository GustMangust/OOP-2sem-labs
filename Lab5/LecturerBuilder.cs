using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IBuilder
    {
        void AddCabinet(string cabinet);
        void AddFullname(string fullname);
        void AddDepartment(string department);
    }
    class LecturerBuilder:IBuilder
    {
        private Lecturer _lecturer = new Lecturer();
        public void Reset()
        {
            this._lecturer = new Lecturer();
        }
        public void AddCabinet(string cabinet)
        {
            this._lecturer.cabinet = cabinet;
        }
        public void AddFullname(string fullname)
        {
            this._lecturer.fullname = fullname;
        }
        public void AddDepartment(string department)
        {
            this._lecturer.department = department;
        }
        public Lecturer GetLecturer()
        {
            Lecturer result = this._lecturer;

            this.Reset();

            return result;
        }
    }
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void buildMinimalLecturer(string fullname)
        {
            this._builder.AddFullname(fullname);
        }

        public void buildFullFeaturedProduct(string fullname, string cabinet,string department)
        {
            this._builder.AddDepartment(department);
            this._builder.AddFullname(fullname);
            this._builder.AddCabinet(cabinet);
        }
    }
}
