﻿using System;
using System.Collections.Generic;
using Xunit;

namespace Akka.Persistence.Tests
{
    public partial class PersistentActorSpec : PersistenceSpec
    {
        public PersistentActorSpec()
        {

        }

        [Fact]
        public void PersistentActor_must_recover_from_persisted_events()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_handle_multiple_emitted_events_in_correct_order_for_a_single_persist_call()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_handle_multiple_emitted_events_in_correct_order_for_a_multiple_persist_calls()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_receive_emitted_events_immediately_after_command()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_recover_on_command_failures()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_allow_behavior_changes_in_event_handler_when_handling_first_event()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_allow_behavior_changes_in_event_handler_when_handling_last_event()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_allow_behavior_changes_in_command_handler_as_first_action()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_allow_behavior_changes_in_command_handler_as_last_action()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_context_become_during_recovery()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_confirmable_persistent()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_reject_Persistent_messages()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_snapshotting()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_be_able_to_reply_within_an_event_handler()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_user_stash_operations()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_user_stash_operations_with_several_stashed_messages()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_user_stash_operations_under_failures()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_be_able_to_persist_struct_events()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_be_able_to_optout_from_stashing_messages_until_all_events_have_been_processed()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_mutliple_PersistAsync_calls_for_one_command_and_execute_them_when_possible_not_hindering()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_reply_to_original_command_sender_even_on_PersistAsync()
        {
            throw new NotImplementedException();
        }


        [Fact]
        public void PersistentActor_must_support_the_same_event_PersistAsync_multiple_times()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_support_mix_of_sync_async_calls_in_expected_order()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_correlate_PersistAsync_handlers_after_restart()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_allow_defering_handlers_in_order_to_provide_ordered_processing_in_respect_to_Persist_handlers()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_allow_defering_handlers_in_order_to_provide_ordered_processing_in_respect_to_PersistAsync_handlers()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void PersistentActor_must_invoke_defered_handlers_in_presence_of_mixed_a_long_series_of_Persist_PersistAsync_calls()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void PersistentActor_must_invoke_defered_handlers_right_away_if_there_are_no_Persist_handlers_registered()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void PersistentActor_must_invoke_deferred_handlers_preserving_the_original_sender_references()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void PersistentActor_must_receive_RecoveryFinished_if_it_is_handled_after_all_events_have_been_replayed()
        {
            throw new NotImplementedException();
        }
    }
}