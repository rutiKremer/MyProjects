import { useEffect, useState } from "react";
import axios from 'axios';
import { EventOfProducer } from "./EventOfProducer";
import { Producer } from "../types/producer";

interface ProducerDetailsProps {
    email: string;
}

export const ProducerDetails = (props: ProducerDetailsProps) => {

    const [producerDetails, setProducerDetails] = useState<Producer | null>(null);
    const [editProducer, setEditProducer] = useState(false);
    const [name, setName] = useState("");
    const [phone, setPhone] = useState("");
    const [description, setDescription] = useState("");
    const [isEdited, setIsEdited] = useState(false);

    const getProducer = async () => {
        try {
            const producer = await axios.get(`http://localhost:3000/producer/${props.email}`);
            setProducerDetails(producer.data);
            setName(producer.data.name); // עדכון ה-state עם הערכים שהתקבלו
            setPhone(producer.data.phone); // עדכון ה-state עם הערכים שהתקבלו
            setDescription(producer.data.description); // עדכון ה-state עם הערכים שהתקבלו
        } catch (err) {
            console.log(err);
        }
    }

    useEffect(() => {
        getProducer();
    }, []);

    const edit = () => {
        setEditProducer(true);
    }

    const saveInMongo = async (event: any) => {
        event.preventDefault(); 
        setIsEdited(true);
        const producer: Producer = {
            name: name,
            email: producerDetails!.email, 
            phone: phone, 
            description: description,
        };
        try {
            await axios.put(`http://localhost:3000/producer/${producerDetails?.email}`, producer);
            alert("update producer successfully!!");
        } catch (err) {
            console.log(err);
        }
    }

    return (
        <div>
            {producerDetails &&  !editProducer || isEdited  && producerDetails ? (
                <div>
                    <h3>Producer Details:</h3>
                    <p>Name: {producerDetails.name}</p>
                    <p>Email: {producerDetails.email}</p>
                    <p>Phone: {producerDetails.phone}</p>
                    <p>Description: {producerDetails.description}</p>
                </div>
            ) : editProducer && producerDetails ? (
                <form onSubmit={saveInMongo}>
                    <input type="text" onChange={p => setName(p.target.value)} value={name} name="name" /><br />
                    <input type="text" value={producerDetails.email} name="email" /><br />
                    <input type="text" onChange={p => setPhone(p.target.value)} value={phone} name="phone" /><br />
                    <input type="text" onChange={p => setDescription(p.target.value)} value={description} name="description" /><br />
                    <button type="submit">save</button>
                </form>
            ) : null}
            
            <button onClick={edit}>edit producer</button>

            <h2>event list</h2>
            <EventOfProducer email={producerDetails ? producerDetails.email : null} />
        </div>
    );
}
