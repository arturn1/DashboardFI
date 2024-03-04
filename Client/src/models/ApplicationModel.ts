import { EnvironmentModel } from "./EnvironmentModel";

export interface ApplicationModel {
    name: string;
    id: string
    environments: EnvironmentModel[]
}