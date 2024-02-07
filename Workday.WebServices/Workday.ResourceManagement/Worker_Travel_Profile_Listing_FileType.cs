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
	public class Worker_Travel_Profile_Listing_FileType : INotifyPropertyChanged
	{
		private Worker_Travel_Profile_Listing_FileObjectType worker_Travel_Profile_Listing_File_ReferenceField;

		private Worker_Travel_Profile_Listing_File_WWSType[] worker_Travel_Profile_Listing_File_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_Travel_Profile_Listing_FileObjectType Worker_Travel_Profile_Listing_File_Reference
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

		[XmlElement("Worker_Travel_Profile_Listing_File_Data", Order = 1)]
		public Worker_Travel_Profile_Listing_File_WWSType[] Worker_Travel_Profile_Listing_File_Data
		{
			get
			{
				return this.worker_Travel_Profile_Listing_File_DataField;
			}
			set
			{
				this.worker_Travel_Profile_Listing_File_DataField = value;
				this.RaisePropertyChanged("Worker_Travel_Profile_Listing_File_Data");
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
