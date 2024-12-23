#pragma once
#include "pch.h"
#include "Utils.h"
#include "Book.h"
#include "EBook.h"

class Library {

private:
    vector<shared_ptr<Book>> books;

public:
    void AddBook(shared_ptr<Book> book);
    //void AddEBook();
    void Clear();

    void SaveToFile(const std::string& filename);
    void LoadFromFile(const std::string& filename);
    shared_ptr<Book> get(int i);

    //shared_ptr<Book> GetBook(int index);
    int GetSize() const;

    template<class Archive>
    void serialize(Archive& ar, const unsigned int version) {
        ar& books;
    }

    void Delete(int id);
};