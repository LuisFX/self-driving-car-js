[<ReactComponent>]
let App (initialPortalsContext : InitialContext) =
    let content =
        reactRouterDom.routes [

            reactRouterDom.route [
                route.path Routes.ApplicationRoute.HealixRoute.ToString
                route.element (
                    RequireAuth
                        {|
                            children = Home ()
                        |}
                )
            ]

            reactRouterDom.route [
                route.path Routes.ApplicationRoute.Landing.ToString
                route.element (
                    Landing ()
                )
            ]

            reactRouterDom.route [
                route.path Routes.ApplicationRoute.SignUp.ToString
                route.element (
                    SignUp ()
                )
            ]

            reactRouterDom.route [
                route.path Routes.ApplicationRoute.Sandbox.ToString
                route.element (
                    Alex ()
                )
            ]

            reactRouterDom.route [
                route.path "*"
                route.element (
                    Html.div [
                        prop.text "BAD ROUTE AT THE APP LEVEL"
                    ]
                )
            ]

        ]

    let indexPage =
        RequireAuth
            {|
                children = Home ()
            |}

    AntidoteContainer
        {|
            IndexPage = indexPage
            Children = content
            InitialPortalsContext = initialPortalsContext
            ApplicationIdentifier = "hlx"
            RedirectToOnLogin = Routes.ApplicationRoute.Healix.ToString + Routes.ApplicationRoute.Splash.ToString
        |}
















