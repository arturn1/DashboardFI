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

export function CardComponent() {
    return (
        <Card className="flex items-center content-center">
            <CardContent className="w-custom">
                <Carousel className="">
                    <CarouselContent>
                        {Array.from({ length: 5 }).map((_, index) => (
                            <CarouselItem key={index} className="w-auto">
                                <CardBodyComponent />
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
