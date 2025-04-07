import axios from 'axios';
import { Producer } from '../types/producer';

export const AddProducer = () => {
 
    const add = (event: any) => {
        console.log("Add function defined");
        event.preventDefault();
        console.log("bv");
        const newProducer: Producer = {
            name: event.target.name.value,
            email: event.target.email.value,
            phone: event.target.phone.value,
            description: event.target.description.value,
        };
        saveInMongo(newProducer);
        event.target.reset();
    }

    const saveInMongo = async (producer: Producer) => {
        try {
            await axios.post('http://localhost:3000/producer', producer);
            alert("add producer succesfuly!!");
        } catch (err) {
            console.log(err);
        }
    };


    return <form onSubmit={add}>
        <input type="text" placeholder="name" name="name"/><br/>
        <input type="text" placeholder="email" name="email"/><br/>
        <input type="text" placeholder="phone" name="phone"/><br/>
        <input type="text" placeholder="description" name="description"/><br/>
        <button type="submit">add</button>
    </form>
}