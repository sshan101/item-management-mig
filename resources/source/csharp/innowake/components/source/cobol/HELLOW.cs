using innowake.mee.@base.api;
using innowake.mee.cobol.api;
using innowake.mee.cobol.api.cics;
using InnoWake.Mee.Cobol.API.CICS;
using innowake.mee.cobol.api.adabas;
using InnoWake.Mee.Base.API;
using InnoWake.Mee.Cobol.API;

namespace Innowake.Components.Source.Cobol
{

    [Cobol]
    public partial class HELLOW : DotNetCobolProgram
    {
        public override void run()
        {
            chainNextMethod("MAIN");
        }

        [Label]
        void MAIN() {
            display("Hello, world.");
        }

    }
}
