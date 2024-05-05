import Footer from "./components/Footer";
import Navbar from "./components/Navbar";

const ForumLayout = ({ children }) => {
  return (
    <div>
      <Navbar />
      <div className="forum-content">
        {children}
      </div>
      <Footer />
    </div>
  );
};

export default ForumLayout;
