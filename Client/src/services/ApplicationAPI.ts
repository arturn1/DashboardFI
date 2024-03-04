import { useState } from "react";
import { ApplicationModel } from "@/models/ApplicationModel";

export const useApps = () => {
    const [apps, setApps] = useState<ApplicationModel[]>([]);

    const fetchApps = async () => {
        const response = await fetch(
            "https://localhost:7213/api/application"
        ).then(resp => resp.json());
        //console.log("resp:", response);

        setApps(response.data);
    };


    return { apps, fetchApps };
};
