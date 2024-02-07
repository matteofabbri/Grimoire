using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Integration_Retrieval_Protocol_DataType : INotifyPropertyChanged
	{
		private Job_Retrieval_Inbound_Protocol_DataType inbound_Protocol_DataField;

		private PGP_Private_Key_PairObjectType decrypt_Using_PGP_Private_Key_Pair_ReferenceField;

		private string filenameField;

		private OMS_EnvironmentObjectType[] restricted_To_Environment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_Retrieval_Inbound_Protocol_DataType Inbound_Protocol_Data
		{
			get
			{
				return this.inbound_Protocol_DataField;
			}
			set
			{
				this.inbound_Protocol_DataField = value;
				this.RaisePropertyChanged("Inbound_Protocol_Data");
			}
		}

		[XmlElement(Order = 1)]
		public PGP_Private_Key_PairObjectType Decrypt_Using_PGP_Private_Key_Pair_Reference
		{
			get
			{
				return this.decrypt_Using_PGP_Private_Key_Pair_ReferenceField;
			}
			set
			{
				this.decrypt_Using_PGP_Private_Key_Pair_ReferenceField = value;
				this.RaisePropertyChanged("Decrypt_Using_PGP_Private_Key_Pair_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
				this.RaisePropertyChanged("Filename");
			}
		}

		[XmlElement("Restricted_To_Environment_Reference", Order = 3)]
		public OMS_EnvironmentObjectType[] Restricted_To_Environment_Reference
		{
			get
			{
				return this.restricted_To_Environment_ReferenceField;
			}
			set
			{
				this.restricted_To_Environment_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_To_Environment_Reference");
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
