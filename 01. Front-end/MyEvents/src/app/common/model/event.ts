import { Speaker } from './speaker';
import { Batch } from "./batch";
import { SocialNetwork } from "./social-network";

export interface Event {
    idEvent: number;  
    local: string;
    eventDate?: Date;
    theme: string;
    numberOfParticipants: number;
    batch: Batch[]; 
    socialNetwork: SocialNetwork[]; 
    imageUrl: string;
    telephone: string;
    email: string;
    speakerEvent: Speaker[];
}