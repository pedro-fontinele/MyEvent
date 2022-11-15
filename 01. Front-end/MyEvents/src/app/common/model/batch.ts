export interface Batch {
    idBatch: number;
    name: string;
    price: number;
    startDate?: Date;
    endDate?: Date;
    theAmount: number;
    idEvent: number;
    event: Event;    
}
