import {
  FaBook,
  FaClock,
  FaExchangeAlt,
  FaHistory,
  FaList,
  FaQuestionCircle,
  FaStar,
  FaUser,
  FaUsers,
} from "react-icons/fa";
import { FiHome } from "react-icons/fi";

export const meSidebarItems = [
  {
    title: "Ana Sayfa",
    icon: <FiHome />,
    href: "/me",
    target: "_self",
  },
  {
    title: "Profilim",
    icon: <FaUser />,
    href: "/me/profile",
    target: "_self",
    subItems: [],
  },
  {
    title: "Kütüphanelerim",
    icon: <FaBook />,
    href: "/me/libraries",
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
    title: "Favoriler",
    icon: <FaStar />,
    href: "/me/favorites",
    target: "_self",
    subItems: [],
  },
  {
    title: "Okuma Listesi",
    icon: <FaList />,
    href: "/me/reading-list",
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
