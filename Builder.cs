using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns2_HW3
{
    class Rifle
    {
        public bool Silencer { get; set; }
        public bool ExtendetMag { get; set; }
        public bool Scope { get; set; }

        public void Observe()
        {
            if (Silencer) Console.WriteLine("Silencer");
            if (ExtendetMag) Console.WriteLine("ExtendetMag");
            if (Scope) Console.WriteLine("Scope");
        }
    }
    abstract class RifleBuilder
    {
        public Rifle CustomRifle { get; set; }
        public void CreateRifle()
        {
            CustomRifle = new Rifle();
        }
        public abstract void SetSilencer(bool has);
        public abstract void SetExtendedMag(bool has);
        public abstract void SetScope(bool has);
    }
    class FullCustomBuilder : RifleBuilder
    {
        public override void SetSilencer(bool has)
        {
            CustomRifle.Silencer = has;
        }

        public override void SetExtendedMag(bool has)
        {
            CustomRifle.ExtendetMag = has;
        }
        public override void SetScope(bool has)
        {
            CustomRifle.Scope = has;
        }
    }
    public class BuilderFullCustom
    {
        public void Build()
        {
            RifleBuilder rifleBuilder = new FullCustomBuilder();
            rifleBuilder.CreateRifle();
            rifleBuilder.SetSilencer(true);
            rifleBuilder.SetExtendedMag(true);
            rifleBuilder.SetScope(true);
            rifleBuilder.CustomRifle.Observe();
        }
    }
}
