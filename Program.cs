using System;

namespace Assessment1
{
    abstract class Institute
    {
        public virtual void coursesoffer()
        {
            Console.WriteLine("Various courses are - C,C++,.NET,JAVA");
        }
        public void discount()
        {
            Console.WriteLine("Discount is Rs 0");
        }
        abstract public void Address();

    }
  
    interface IpaperAds
    {
        public void PaperDetail();

    }

    interface ISocialMediaAds
    {
        public void CampaignDetail();

    }
    interface IvehicleAds
    {
        public void AddDetail();

    }
  
    sealed class KnightLearningSolutions : Institute, IpaperAds, ISocialMediaAds, IvehicleAds
    {
        public new void discount()
        {

            base.discount();
            Console.WriteLine("KNLS class Discount at 10%");
        }
        public override void Address()
        {
            Console.WriteLine("Address detail of KNLS");
        }
        public void paperdetail()
        {
            Console.WriteLine("Newspaper ad details");
        }
        public void campigndetails()
        {
            Console.WriteLine("SM Campaign details");
        }
        public void Addetails()
        {
            Console.WriteLine("Bus ad route details");
        }


    }

    sealed class SonlineTrainings : Institute, ISocialMediaAds
    {
        public override void coursesoffer()
        {
            Console.WriteLine("The Courses offered are - AZURE,FLUTTER,XAMARIN");
        }


        public override void Address()

        {
            Console.WriteLine("Address details of SOT");

        }

        public void campigndetails()
        {
            Console.WriteLine("SM Campaign details");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            KnightLearningSolutions kls = new KnightLearningSolutions();
            kls.coursesoffer();
            kls.discount();
            kls.Address();
            kls.paperdetail();
            kls.campigndetails();
            kls.Addetails();

            SonlineTrainings st= new SonlineTrainings();
            st.coursesoffer();
            st.discount();
            st.Address();
            st.campigndetails();

            Institute i = new KnightLearningSolutions();
            i.coursesoffer();
            i.discount();
            i.Address();

            Institute inst1 = new SonlineTrainings();
            inst1.coursesoffer();
            inst1.discount();
            inst1.Address();


        }
    }
}
