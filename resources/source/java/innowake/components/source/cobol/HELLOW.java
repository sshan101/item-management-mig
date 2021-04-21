package innowake.components.source.cobol;

import innowake.mee.base.api.*;
import innowake.mee.cobol.api.*;
import innowake.mee.cobol.api.cics.*;
import innowake.mee.cobol.api.Cobol.Transformation;

@Cobol(programID = "HELLOWORLD", version = Transformation.V3)
public class HELLOW extends CobolProgram {

    /* FD definitions */

    @Override
    public void run() {
        chainNextMethod("MAIN");
    }

    @Label
    void MAIN() {
        display("Hello, world.");
    }

}
