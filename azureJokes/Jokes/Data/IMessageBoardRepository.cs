using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes.Data
{
  public interface IJokesRepository
  {
    IQueryable<Topic> GetTopics();
    IQueryable<Topic> GetTopicsIncludingReplies();
    IQueryable<Reply> GetRepliesByTopic(int topicId);

    bool Save();

    bool AddTopic(Topic newTopic);
    bool AddReply(Reply newReply);
  }
}
