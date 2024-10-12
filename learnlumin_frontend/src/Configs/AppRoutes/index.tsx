import React, { FC } from "react";
import { Route, Routes } from "react-router-dom";
import App from "../../App"
import Home from "../../Components/Home/Home"
import Courses from "../../Components/Courses"
import Quizzes from "../../Components/Quizzes"
import Community from "../../Components/Community"
import LiveClasses from "../../Components/LiveClasses"
import About from "../../Components/About"
import Profile from "../../Components/Profile";

export const AppRoutes: FC = () => {
    
    return(

        <Routes>
            <Route path={"/"} element={<App/>} >
                <Route path = {"/"} element = {<Home/>}/>
                <Route path = {"/Courses"} element = {<Courses/>}/>
                <Route path = {"/Quizzes"} element = {<Quizzes/>}/>
                <Route path = {"/Community"} element = {<Community/>}/>
                <Route path = {"/LiveClasses"} element = {<LiveClasses/>}/>
                <Route path = {"/Profile"} element = {<Profile/>}/>
                <Route path = {"/About"} element = {<About/>}/>
            </Route>

            </Routes>
        
        );

}