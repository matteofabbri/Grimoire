using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Travel_Profile_Listing_File_Request_ReferencesType : INotifyPropertyChanged
	{
		private Worker_Travel_Profile_Listing_FileObjectType[] worker_Travel_Profile_Listing_File_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_Travel_Profile_Listing_File_Reference", Order = 0)]
		public Worker_Travel_Profile_Listing_FileObjectType[] Worker_Travel_Profile_Listing_File_Reference
		{
			get
			{
				return this.worker_Travel_Profile_Listing_File_ReferenceField;
			}
			set
			{
				this.worker_Travel_Profile_Listing_File_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Travel_Profile_Listing_File_Reference");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
