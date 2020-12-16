using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using КурсовойПроект.Domain.Entities;

namespace КурсовойПроект.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GeTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity) { }
        void DeleteTextField(Guid id) { }
    }
}
