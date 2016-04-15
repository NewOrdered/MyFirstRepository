using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HistorianTrendViewer.BL;

namespace HistorianTrendViewer
{
    public class ServersPresenter
    {
        private readonly IFrmServers view;
        private readonly IHistorianServersRepository serversRepository;

        public ServersPresenter(IFrmServers _view, IHistorianServersRepository _repository)
        {
            view = _view;
            serversRepository = _repository;

            serversRepository.LoadServers();

            view.LoadServersList(serversRepository.List);

            view.ServerSelected +=new EventHandler(view_ServerSelected);
            view.SaveServerClick +=new EventHandler(view_SaveServerClick);
            view.CloseClick +=new EventHandler(view_CloseClick);
            view.RemoveServerClick +=new EventHandler(view_RemoveServerClick);
            view.AddServerClick +=new EventHandler(view_AddServerClick);
            view.NewServerClick +=new EventHandler(view_NewServerClick);
            view.ViewLoaded +=new EventHandler(view_ViewLoaded);
        }

        private void view_ViewLoaded(object sender, EventArgs e)
        {
            
        }

        private void view_ServerSelected(object sender, EventArgs e)
        {
                var id = view.SelectedServerId;
                view.SelectedServer = serversRepository.Clone(serversRepository.GetServerById(id));
                view.LoadServerDetails(view.SelectedServer);
        }

        private void view_SaveServerClick(object sender, EventArgs e)
        {
            if (view.SelectedServer != null)
            {
                serversRepository.ReplaceById(view.SelectedServerId, view.SelectedServer);
                view.UpdateList();
            }
        }

        private void view_RemoveServerClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(view.SelectedServerId))
            {
                serversRepository.RemoveById(view.SelectedServerId);
                view.UpdateList();
            }

        }

        private void view_CloseClick(object sender, EventArgs e)
        {
            serversRepository.SaveServers();
        }

        private void view_AddServerClick(object sender, EventArgs e)
        {
            if (view.SelectedServer != null)
            {
                serversRepository.Add(view.SelectedServer);
                view.UpdateList();
            }
        }

        private void view_NewServerClick(object sender, EventArgs e)
        {
            view.SelectedServer = serversRepository.Create();
            view.LoadServerDetails(view.SelectedServer);
        }
    }
}
