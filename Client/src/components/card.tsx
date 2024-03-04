import { Card, CardContent } from "@/components/ui/card"
import {
    Carousel,
    CarouselContent,
    CarouselItem,
    CarouselNext,
    CarouselPrevious,
} from "@/components/ui/carousel"
// import { CardBodyComponent } from "./card-body"
import '../App.css'
import { CardBodyComponent } from "./card-body"
import { ApplicationModel } from "@/models/ApplicationModel"

interface ICardBodyComponent {
    prop: ApplicationModel
    key: string
}

export const CardComponent = (app: ICardBodyComponent) => {

    const { environments } = app.prop


    return (
        <Card className="flex items-center content-center">
            <CardContent className="w-custom">
                <Carousel className="">
                    <CarouselContent>
                        {environments.map((_, index) => (
                            <CarouselItem key={index} className="w-auto">
                                <CardBodyComponent prop={app.prop} index={index} />
                            </CarouselItem>
                        ))}
                    </CarouselContent>
                    <CarouselPrevious />
                    <CarouselNext />
                </Carousel>
            </CardContent>
        </Card>
    )
}
