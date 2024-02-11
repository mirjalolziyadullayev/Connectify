using Connectify.Models;

namespace Connectify.Interfaces;

public interface IMessageService
{
    Message Create(Message message);
    Message Update(int id, Message message);
    bool Delete(int id);
    Message Get(int id);
    List<Message> GetAll();
}