import { VersionModel } from "./VersionModel";

export interface EnvironmentModel {
    name: string;
    link: string;
    links: string;
    versions: VersionModel[];
}