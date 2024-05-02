import {
  FaBook,
  FaClock,
  FaExchangeAlt,
  FaHistory,
  FaQuestionCircle,
  FaUser,
  FaUsers,
} from "react-icons/fa";

export const meSidebarItems = [
  {
    title: "Profil Yönetimi",
    icon: <FaUser />,
    href: "/me/profile",
    target: "_self",
    subItems: [],
  },
  {
    title: "Kütüphane Yönetimi",
    icon: <FaBook />,
    href: "/me/library",
    target: "_self",
    subItems: [],
  },
  {
    title: "Kitap Alım ve Teslim",
    icon: <FaExchangeAlt />,
    href: "/me/borrow",
    target: "_self",
    subItems: [],
  },
  {
    title: "Geçmiş Alınan Kitaplar",
    icon: <FaHistory />,
    href: "/me/past-books",
    target: "_self",
    subItems: [],
  },
  {
    title: "Destek",
    icon: <FaQuestionCircle />,
    href: "/me/support",
    target: "_self",
    subItems: [],
  },
  {
    title: "Sosyalleşme",
    icon: <FaUsers />,
    href: "/me/social",
    target: "_self",
    subItems: [],
  },
];
