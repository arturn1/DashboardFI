import { CardContent, CardHeader, CardTitle, CardDescription, CardFooter } from "@/components/ui/card";
import { Button } from "@/components/ui/button";
import { ApplicationModel } from "@/models/ApplicationModel";
import { format } from 'date-fns';
import {
    Select,
    SelectContent,
    SelectGroup,
    SelectItem,
    SelectTrigger,
    SelectValue,
} from "@/components/ui/select"
import {
    Dialog,
    DialogContent,
    DialogDescription,
    DialogHeader,
    DialogTitle,
    DialogTrigger,
} from "@/components/ui/dialog"
import { useState } from "react";

interface ICardBodyComponent {
    prop: ApplicationModel
    index: number
}

export const CardBodyComponent = (app: ICardBodyComponent) => {

    const [selected, useSelected] = useState(0);

    const { name, environments } = app.prop
    const i = app.index

    const links = environments[i].links.split(';');
    let tasks: string[] = environments[i].versions[selected].tasks[0]?.tasks.split(';');

    const versionsSelect = environments[i].versions.map((version, index) => {
        return (
            <SelectItem key={index} value={index.toString()}>{version.name}</SelectItem>
        );
    });

    const GetValue = (e: number) => {
        useSelected(e);
        tasks = environments[i].versions[selected].tasks[0]?.tasks.split(';');
    }

    console.log(tasks)

    return (
        <CardContent>
            <CardHeader>
                <a href={environments[i].link} className="mb-2">
                    <CardTitle>{name} - {environments[i].name}</CardTitle>
                </a>
                <div className="flex items-center justify-evenly">
                    <CardDescription >Versão:</CardDescription>
                    <Select onValueChange={(e) => GetValue(e)}>
                        <SelectTrigger className="w-[100px] h-[30px]">
                            <SelectValue placeholder={environments[i].versions[0].name} />
                        </SelectTrigger>
                        <SelectContent>
                            <SelectGroup>
                                {versionsSelect}
                            </SelectGroup>
                        </SelectContent>
                    </Select>
                </div>
                <CardDescription>{format(environments[i]?.versions[selected].releaseDate, 'dd/MM/yyyy')}</CardDescription>
            </CardHeader>
            <CardContent className="flex flex-col">
                <a href={links[0]}>AppService</a>
                <a href={links[1]}>Database</a>
                <a href={links[2]}>Storage Account</a>
            </CardContent>
            <CardFooter className="flex flex-col">
                <Dialog>
                    <DialogTrigger asChild>
                        <Button variant="outline">Visualizar tarefas</Button>
                    </DialogTrigger>
                    <DialogContent>
                        <DialogHeader>
                            <DialogTitle>Tarefas</DialogTitle>
                            {tasks?.map((task: string, index) =>
                                <DialogDescription key={index}>
                                    {task}
                                </DialogDescription>
                            )}
                        </DialogHeader>
                    </DialogContent>
                </Dialog>
                <Button className="my-2" >Solicitar deploy</Button>

            </CardFooter>
        </CardContent>
    )
}
