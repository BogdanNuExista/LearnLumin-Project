import React from "react";
import { BrowserRouter } from "react-router-dom";
import { AppRoutes } from "./Configs/AppRoutes";
import ReactDOM from "react-dom/client";
import "./index.css";

const root = ReactDOM.createRoot(document.getElementById("root")!);

root.render(
    <BrowserRouter>
        <AppRoutes />
    </BrowserRouter>
);