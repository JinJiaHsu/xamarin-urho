using System.Diagnostics;
using Urho;

namespace BLE
{
    public class UrhoChart : Application
    {
        public UrhoChart(ApplicationOptions options = null) : base(options) { }

        static UrhoChart()
        {
            UnhandledException += (s, e) =>
                {
                    if (Debugger.IsAttached)
                        Debugger.Break();
                    e.Handled = true;
                };
        }

        protected override void Start()
        {
            base.Start();
        }

        protected override void OnUpdate(float timeStep)
        {
            base.OnUpdate(timeStep);
        }

        protected override void Stop()
        {
            base.Stop();
        }
    }
}