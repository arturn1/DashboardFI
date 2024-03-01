import { CardContent, CardHeader, CardTitle, CardDescription, CardFooter } from "@/components/ui/card";
import { Button } from "@/components/ui/button";

export function CardBodyComponent() {
    return (
        <CardContent>
            <CardHeader>
                <CardTitle>Lei do Bem</CardTitle>
                <CardDescription>Deploy your new project in one-click.</CardDescription>
            </CardHeader>
            <CardContent>
                <h1>Azure</h1>
            </CardContent>
            <CardFooter className="flex flex-col">
                <Button className="my-2" variant="outline">Solicitar deploy</Button>
                <Button className="">Visualizar</Button>
            </CardFooter>
        </CardContent>
    )
}
