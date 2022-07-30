export interface Order {
    id: number;
    sendername: string ;
    senderemail: string; 
    placedon: Date;
    price: number;
    item: string;
    recipientName: string;
    recipientSurname: string; 
    recipientEmail: string; 
    voucher: number;
}

export interface Item {
    name: string;
    value: string;
    price: number;
}
