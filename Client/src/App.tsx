import { ThemeProvider } from "@/components/theme-provider"
import { ModeToggle } from "./components/mode-toggle"
import { CardComponent } from "./components/card"
import './App.css'

function App() {
    function createCards() {
        const cards = [];

        for (let i = 0; i < 6; i++) {
            cards.push(<CardComponent />);
        }

        return cards;
    }

    return (
        <ThemeProvider defaultTheme="dark" storageKey="vite-ui-theme">
            <div>
                <ModeToggle />
                <div className="grid card__container gap-24 mx-20">
                    {createCards()}
                </div>
            </div>
        </ThemeProvider>
    )
}

export default App
