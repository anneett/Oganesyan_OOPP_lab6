#pragma once
#include "pch.h"
#include "Book.h"
#include "EBook.h"

class Library {

private:

    vector<shared_ptr<Book>> books;

public:

    shared_ptr<Book> get(int i);
    int GetSize() const;

    void AddBook(shared_ptr<Book> book);
    void SaveToFile(const string& filename);
    void LoadFromFile(const string& filename);
    void Delete(int id);
    void Clear();

    template<class Archive>
    void serialize(Archive& ar, const unsigned int version) {
        ar& books;
    }
};