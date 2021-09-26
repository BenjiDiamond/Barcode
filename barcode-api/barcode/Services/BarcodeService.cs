
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace barcode.Services {
public class BarcodeService{
    private readonly IMongoCollection<barcode> _barcodes;
    public BarcodeService()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017/?readPreference=primary&appname=mongodb-vscode%200.6.10&directConnection=true&ssl=false");
            var database = client.GetDatabase("mongodbVSCodePlaygroundDB");

            _barcodes = database.GetCollection<barcode>("items");
        }
        public List<barcode> Get() =>
            _barcodes.Find(barcode => true).ToList();

        public barcode Get(string id) =>
            _barcodes.Find<barcode>(barcode => barcode._id == id).FirstOrDefault();

        public barcode Create(barcode model)
        {
            _barcodes.InsertOne(model);
            return model;
        }

        public void Update(string id, barcode barcodeIn) =>
            _barcodes.ReplaceOne(barcode => barcode._id == id, barcodeIn);

        public void Remove(barcode barcodeIn) =>
            _barcodes.DeleteOne(barcode => barcode._id == barcodeIn._id);

        public void Remove(string id) => 
            _barcodes.DeleteOne(barcode => barcode._id == id);
    }
}