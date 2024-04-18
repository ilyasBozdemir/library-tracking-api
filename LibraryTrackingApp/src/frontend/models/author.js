export const authorModel = [
    { key: "name", label: "Ad", type: "text", placeholder: "Adınızı girin" },
    { key: "surname", label: "Soyad", type: "text", placeholder: "Soyadınızı girin" },
    { key: "birthDate", label: "Doğum Tarihi", type: "date", placeholder: "Doğum tarihinizi seçin" },
    { key: "country", label: "Ülke", type: "select", placeholder: "Ülke seçin", options: [
      { value: "turkey", label: "Türkiye" },
      { value: "usa", label: "ABD" },
      { value: "uk", label: "İngiltere" },
    ] },
    { key: "biography", label: "Biyografi", type: "text", placeholder: "Biyografinizi girin" },
  ];
  