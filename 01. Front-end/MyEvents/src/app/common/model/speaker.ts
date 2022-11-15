import { SocialNetwork } from "./social-network";

export interface Speaker {
    idSpeaker: number;
    name: string;
    summary: string;
    imageUrl: string;
    telephone: string;
    email: string;
    socialNetwork: SocialNetwork[];
    speakerEvent: Event[];
}