import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter, Route, Routes } from 'react-router';
import {EventDetailsForProducer} from './component/EventDetailsForProducer.tsx'
import { UsersMenu } from './component/UsersMenu.tsx';
import { ProducerMenu } from './component/ProducerMenu.tsx';
import App from './App.tsx';
import './index.css';
import { EventDetailsForUser } from './component/EventDetailsForUser.tsx';

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <BrowserRouter>
      <App/>
      <Routes>
        <Route path="/UsersMenu" element={<UsersMenu />}>
        </Route>       
        <Route path="/ProducerMenu" element={<ProducerMenu />} >
        </Route>
        <Route path="/event/:_id/:name/:description/:producerId" element={<EventDetailsForProducer/>} />
        <Route path="/event/:_id/:name/:description/:producerId" element={<EventDetailsForUser/>} />
      </Routes>
    </BrowserRouter>
  </StrictMode >,
)






