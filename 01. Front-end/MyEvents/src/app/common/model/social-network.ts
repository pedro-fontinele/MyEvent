import { Speaker } from "./speaker";

export interface SocialNetwork {
    idSocialNetwork: number;
    name: string;
    url: string;
    idEvent?: number;
    event: Event;
    idSpeaker?: number;
    speaker: Speaker;
}
