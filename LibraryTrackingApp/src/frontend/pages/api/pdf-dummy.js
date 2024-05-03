import fs from 'fs';
import path from 'path';

export default function handler(req, res) {
    
  const filePath = path.join(process.cwd(), 'public', 'pdf-dummy.pdf');

  fs.readFile(filePath, (err, data) => {
    if (err) {
      console.error(err);
      res.status(500).end();
      return;
    }

    res.setHeader('Content-Type', 'application/pdf');
    res.status(200).send(data);
  });
}
