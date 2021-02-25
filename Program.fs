// Learn more about F# at http://fsharp.org

open System

open OpenTK.Windowing.Common
open OpenTK.Windowing.Desktop
open OpenTK.Graphics.OpenGL
open OpenTK.Mathematics

type Scene(GWS, NWS) =
    inherit GameWindow(GWS, NWS)


    override this.OnRenderFrame(e) =
        base.OnRenderFrame(e)
        GL.Clear(ClearBufferMask.ColorBufferBit)

        this.SwapBuffers()

    override this.OnLoad() =
        base.OnLoad()
        GL.ClearColor(1.0f ,0.0f ,0.0f ,1.0f)

[<EntryPoint>]
let main argv =

    let NWS = new NativeWindowSettings()

    NWS.Size <- new Vector2i(1000,1000)
    NWS.Title <- "Window"
    NWS.StartFocused <- true
    NWS.StartVisible <- true
    NWS.APIVersion <- new Version(3,2)
    NWS.Flags <- ContextFlags.ForwardCompatible
    NWS.Profile <- ContextProfile.Core

    let wind = new Scene(GameWindowSettings.Default, NWS)
    wind.Run()
    0
