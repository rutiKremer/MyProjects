import { useParams } from "react-router";
import { useState, useEffect } from "react";
import axios from 'axios';
import { Event } from '../types/event';

export const EventDetailsForProducer = () => {
  const params = useParams();
  const { _id, name, description, producerId } = params;

  const [_id2, setId2] = useState("");
  const [name2, setName2] = useState("");
  const [description2, setDescription2] = useState("");
  const [producerId2, setProducerId2] = useState("");
  const [edit, setEdit] = useState(false);

  useEffect(() => {
    if (edit) {
      setId2(_id!);
      setName2(name!);
      setDescription2(description!);
      setProducerId2(producerId!);
    }
  }, [edit, _id, name, description, producerId]);

  const saveInMongo = async (event: any) => {
    event.preventDefault();

    const event2: Event = {
      _id: _id2,
      name: name2,
      description: description2,
      producerId: producerId2
    };
    try {
      await axios.put(`http://localhost:3000/events/${_id2}`, event2);
      alert("update producer successfully!!");
    } catch (err) {
      console.log(err);
    }
  }

  return (
    <div>
      {!edit ? (
        <div>
          <h3>Event Details:</h3>
          <h2>id: {_id}</h2>
          <h2>name: {name}</h2>
          <h2>description: {description}</h2>
          <h2>producerId: {producerId}</h2>
          <button onClick={() => setEdit(true)}>edit event</button>
        </div>
      ) : (
        <form onSubmit={saveInMongo}>
          <input type="text" onChange={p => setId2(p.target.value)} value={_id2} name="_id" /><br />
          <input type="text" onChange={p => setName2(p.target.value)} value={name2} name="name" /><br />
          <input type="text" onChange={p => setDescription2(p.target.value)} value={description2} name="description" /><br />
          <input type="text" onChange={p => setProducerId2(p.target.value)} value={producerId2} name="producerId" /><br />
          <button type="submit">save</button>
        </form>
      )}
    </div>
  )
}
