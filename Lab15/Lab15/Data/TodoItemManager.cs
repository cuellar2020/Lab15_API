using Lab15.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Data
{
    public class TodoItemManager
    {
        IRestService restService;

        public TodoItemManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<TodoItem>> GetTasksAsync ()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveTaskASync (TodoItem item, bool isNewItem = false)
        {
            return restService.SaveTodoItemAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync (TodoItem item)
        {
            return restService.DeleteTodoItemAsync(item.ID);
        }
    }
}
