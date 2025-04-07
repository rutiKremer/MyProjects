 import axios from 'axios';
 import { Event } from '../types/event';

export const AddEvent = () => {
    
    const saveInMongo = async (event:Event) => {
        try{
             await axios.post('http://localhost:3000/events',event);         
        }catch(err){
            console.log(err);           
        }
    }; 

    const add = async (event:any) => {
        event.preventDefault();  
        
        const newEvent :Event = {
            _id:event.target._id.value,
            name:event.target.name.value,
            description:event.target.description.value,
            producerId:event.target.producerId.value
        };
        await saveInMongo(newEvent);
        event.target.reset();
    }
    
    return <form onSubmit={add}>        
    <input type="text" placeholder="_id" name="_id"/><br/>     
    <input type="text" placeholder="name" name="name"/><br/>     
    <input type="text" placeholder="description" name="description"/><br/>
    <input type="text" placeholder="producerId" name="producerId"/><br/>
    <button type="submit">add</button>
</form>
}
