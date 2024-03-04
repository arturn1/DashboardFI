import { TaskModel } from "./TaskModel";

export interface VersionModel {
    name: string;
    releaseDate: Date;
    tasks: TaskModel[];
    id: string
}