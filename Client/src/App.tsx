import { ThemeProvider } from "@/components/theme-provider"
import { CardComponent } from "./components/card"
import './App.css'
import { useApps } from "./services/ApplicationAPI"
import { useEffect } from "react"
import { ApplicationModel } from "./models/ApplicationModel"

function App() {

    const { apps, fetchApps } = useApps();

    useEffect(() => {
        fetchApps();
    }, []);

    return (
        <ThemeProvider defaultTheme="dark" storageKey="vite-ui-theme">
            <div>
                <div className="grid card__container gap-24 mx-20">
                    {
                        apps.map((app: ApplicationModel) => (
                            <CardComponent prop={app} key={app.id} />
                        ))
                    }
                </div>
            </div>
        </ThemeProvider>
    )
}

export default App
